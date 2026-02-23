using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Fenerbahce;

/// <summary>
/// Abstract class for Fenerbahce (genus).
/// NCBI TaxId: 1133800
/// </summary>
public abstract class Fenerbahce : Nothobranchiidae, IFenerbahce
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fenerbahce";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1133800;

    /// <inheritdoc />
    public virtual string GenusName => "Fenerbahce";

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
