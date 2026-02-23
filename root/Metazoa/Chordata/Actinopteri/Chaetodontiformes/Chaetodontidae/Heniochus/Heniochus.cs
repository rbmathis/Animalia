using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Heniochus;

/// <summary>
/// Abstract class for Heniochus (genus).
/// NCBI TaxId: 109916
/// </summary>
public abstract class Heniochus : Chaetodontidae, IHeniochus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heniochus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109916;

    /// <inheritdoc />
    public virtual string GenusName => "Heniochus";

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
