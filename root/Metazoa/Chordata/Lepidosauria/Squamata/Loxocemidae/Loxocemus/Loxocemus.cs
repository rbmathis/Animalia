using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Loxocemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Loxocemidae.Loxocemus;

/// <summary>
/// Abstract class for Loxocemus (genus).
/// NCBI TaxId: 39077
/// </summary>
public abstract class Loxocemus : Loxocemidae, ILoxocemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loxocemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39077;

    /// <inheritdoc />
    public virtual string GenusName => "Loxocemus";

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
