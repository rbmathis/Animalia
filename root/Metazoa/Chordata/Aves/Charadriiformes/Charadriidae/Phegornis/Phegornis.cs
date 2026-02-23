using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Phegornis;

/// <summary>
/// Abstract class for Phegornis (genus).
/// NCBI TaxId: 227178
/// </summary>
public abstract class Phegornis : Charadriidae, IPhegornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phegornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227178;

    /// <inheritdoc />
    public virtual string GenusName => "Phegornis";

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
