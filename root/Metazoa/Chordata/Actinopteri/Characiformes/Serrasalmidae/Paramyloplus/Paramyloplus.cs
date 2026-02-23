using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Paramyloplus;

/// <summary>
/// Abstract class for Paramyloplus (genus).
/// NCBI TaxId: 3363452
/// </summary>
public abstract class Paramyloplus : Serrasalmidae, IParamyloplus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paramyloplus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363452;

    /// <inheritdoc />
    public virtual string GenusName => "Paramyloplus";

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
