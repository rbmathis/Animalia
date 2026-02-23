using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Campogramma;

/// <summary>
/// Abstract class for Campogramma (genus).
/// NCBI TaxId: 2023789
/// </summary>
public abstract class Campogramma : Carangidae, ICampogramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Campogramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2023789;

    /// <inheritdoc />
    public virtual string GenusName => "Campogramma";

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
