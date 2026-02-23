using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Ardeola;

/// <summary>
/// Abstract class for Ardeola (genus).
/// NCBI TaxId: 188374
/// </summary>
public abstract class Ardeola : Ardeidae, IArdeola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ardeola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188374;

    /// <inheritdoc />
    public virtual string GenusName => "Ardeola";

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
