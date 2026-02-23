using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Aglaiocercus;

/// <summary>
/// Abstract class for Aglaiocercus (genus).
/// NCBI TaxId: 304596
/// </summary>
public abstract class Aglaiocercus : Trochilidae, IAglaiocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aglaiocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304596;

    /// <inheritdoc />
    public virtual string GenusName => "Aglaiocercus";

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
