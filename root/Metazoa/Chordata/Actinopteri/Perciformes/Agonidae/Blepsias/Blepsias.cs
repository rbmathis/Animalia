using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Blepsias;

/// <summary>
/// Abstract class for Blepsias (genus).
/// NCBI TaxId: 573212
/// </summary>
public abstract class Blepsias : Agonidae, IBlepsias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blepsias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 573212;

    /// <inheritdoc />
    public virtual string GenusName => "Blepsias";

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
