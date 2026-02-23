using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Peltohyas;

/// <summary>
/// Abstract class for Peltohyas (genus).
/// NCBI TaxId: 425649
/// </summary>
public abstract class Peltohyas : Charadriidae, IPeltohyas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peltohyas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425649;

    /// <inheritdoc />
    public virtual string GenusName => "Peltohyas";

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
