using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae.Exiliboa;

/// <summary>
/// Abstract class for Exiliboa (genus).
/// NCBI TaxId: 196257
/// </summary>
public abstract class Exiliboa : Tropidophiidae, IExiliboa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exiliboa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 196257;

    /// <inheritdoc />
    public virtual string GenusName => "Exiliboa";

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
