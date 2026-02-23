using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae.Cynoglossus;

/// <summary>
/// Abstract class for Cynoglossus (genus).
/// NCBI TaxId: 106173
/// </summary>
public abstract class Cynoglossus : Cynoglossidae, ICynoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 106173;

    /// <inheritdoc />
    public virtual string GenusName => "Cynoglossus";

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
