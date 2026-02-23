using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Urocissa;

/// <summary>
/// Abstract class for Urocissa (genus).
/// NCBI TaxId: 56795
/// </summary>
public abstract class Urocissa : Corvidae, IUrocissa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urocissa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56795;

    /// <inheritdoc />
    public virtual string GenusName => "Urocissa";

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
