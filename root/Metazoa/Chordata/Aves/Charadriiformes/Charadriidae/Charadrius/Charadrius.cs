using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Charadrius;

/// <summary>
/// Abstract class for Charadrius (genus).
/// NCBI TaxId: 50391
/// </summary>
public abstract class Charadrius : Charadriidae, ICharadrius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Charadrius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50391;

    /// <inheritdoc />
    public virtual string GenusName => "Charadrius";

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
