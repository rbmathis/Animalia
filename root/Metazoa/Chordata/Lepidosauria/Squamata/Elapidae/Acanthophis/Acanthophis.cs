using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Acanthophis;

/// <summary>
/// Abstract class for Acanthophis (genus).
/// NCBI TaxId: 8604
/// </summary>
public abstract class Acanthophis : Elapidae, IAcanthophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8604;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthophis";

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
