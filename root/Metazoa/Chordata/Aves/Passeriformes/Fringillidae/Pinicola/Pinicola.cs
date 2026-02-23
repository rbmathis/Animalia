using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Pinicola;

/// <summary>
/// Abstract class for Pinicola (genus).
/// NCBI TaxId: 175946
/// </summary>
public abstract class Pinicola : Fringillidae, IPinicola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pinicola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175946;

    /// <inheritdoc />
    public virtual string GenusName => "Pinicola";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
