using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Rhadinesthes;

/// <summary>
/// Abstract class for Rhadinesthes (genus).
/// NCBI TaxId: 882882
/// </summary>
public abstract class Rhadinesthes : Stomiidae, IRhadinesthes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhadinesthes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882882;

    /// <inheritdoc />
    public virtual string GenusName => "Rhadinesthes";

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
