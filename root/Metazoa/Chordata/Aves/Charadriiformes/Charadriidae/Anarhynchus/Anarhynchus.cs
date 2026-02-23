using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Anarhynchus;

/// <summary>
/// Abstract class for Anarhynchus (genus).
/// NCBI TaxId: 425625
/// </summary>
public abstract class Anarhynchus : Charadriidae, IAnarhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anarhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425625;

    /// <inheritdoc />
    public virtual string GenusName => "Anarhynchus";

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
