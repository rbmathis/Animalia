using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Arenophryne;

/// <summary>
/// Abstract class for Arenophryne (genus).
/// NCBI TaxId: 356260
/// </summary>
public abstract class Arenophryne : Myobatrachidae, IArenophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arenophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356260;

    /// <inheritdoc />
    public virtual string GenusName => "Arenophryne";

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
