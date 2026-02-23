using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Centropogon;

/// <summary>
/// Abstract class for Centropogon (genus).
/// NCBI TaxId: 210578
/// </summary>
public abstract class Centropogon : Tetrarogidae, ICentropogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centropogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210578;

    /// <inheritdoc />
    public virtual string GenusName => "Centropogon";

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
