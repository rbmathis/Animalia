using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Dromadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Dromadidae.Dromas;

/// <summary>
/// Abstract class for Dromas (genus).
/// NCBI TaxId: 458189
/// </summary>
public abstract class Dromas : Dromadidae, IDromas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dromas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458189;

    /// <inheritdoc />
    public virtual string GenusName => "Dromas";

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
