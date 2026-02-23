using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Astronesthes;

/// <summary>
/// Abstract class for Astronesthes (genus).
/// NCBI TaxId: 700624
/// </summary>
public abstract class Astronesthes : Stomiidae, IAstronesthes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astronesthes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 700624;

    /// <inheritdoc />
    public virtual string GenusName => "Astronesthes";

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
