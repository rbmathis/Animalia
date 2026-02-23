using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Denticipitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Denticipitidae.Denticeps;

/// <summary>
/// Abstract class for Denticeps (genus).
/// NCBI TaxId: 299320
/// </summary>
public abstract class Denticeps : Denticipitidae, IDenticeps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Denticeps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 299320;

    /// <inheritdoc />
    public virtual string GenusName => "Denticeps";

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
