using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Crossobamon;

/// <summary>
/// Abstract class for Crossobamon (genus).
/// NCBI TaxId: 401521
/// </summary>
public abstract class Crossobamon : Gekkonidae, ICrossobamon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crossobamon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 401521;

    /// <inheritdoc />
    public virtual string GenusName => "Crossobamon";

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
