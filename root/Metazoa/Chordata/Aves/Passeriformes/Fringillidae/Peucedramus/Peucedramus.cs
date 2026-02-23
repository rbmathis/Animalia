using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Peucedramus;

/// <summary>
/// Abstract class for Peucedramus (genus).
/// NCBI TaxId: 135440
/// </summary>
public abstract class Peucedramus : Fringillidae, IPeucedramus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peucedramus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135440;

    /// <inheritdoc />
    public virtual string GenusName => "Peucedramus";

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
