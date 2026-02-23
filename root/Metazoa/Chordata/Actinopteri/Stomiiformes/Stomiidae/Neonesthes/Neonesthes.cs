using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Neonesthes;

/// <summary>
/// Abstract class for Neonesthes (genus).
/// NCBI TaxId: 882843
/// </summary>
public abstract class Neonesthes : Stomiidae, INeonesthes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neonesthes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882843;

    /// <inheritdoc />
    public virtual string GenusName => "Neonesthes";

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
