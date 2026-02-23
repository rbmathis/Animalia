using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Anstisia;

/// <summary>
/// Abstract class for Anstisia (genus).
/// NCBI TaxId: 3083002
/// </summary>
public abstract class Anstisia : Myobatrachidae, IAnstisia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anstisia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3083002;

    /// <inheritdoc />
    public virtual string GenusName => "Anstisia";

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
