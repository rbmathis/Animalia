using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Myobatrachus;

/// <summary>
/// Abstract class for Myobatrachus (genus).
/// NCBI TaxId: 251755
/// </summary>
public abstract class Myobatrachus : Myobatrachidae, IMyobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 251755;

    /// <inheritdoc />
    public virtual string GenusName => "Myobatrachus";

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
