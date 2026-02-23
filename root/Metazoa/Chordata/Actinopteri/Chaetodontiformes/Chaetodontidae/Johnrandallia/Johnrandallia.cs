using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Johnrandallia;

/// <summary>
/// Abstract class for Johnrandallia (genus).
/// NCBI TaxId: 466147
/// </summary>
public abstract class Johnrandallia : Chaetodontidae, IJohnrandallia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Johnrandallia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 466147;

    /// <inheritdoc />
    public virtual string GenusName => "Johnrandallia";

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
