using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Porichthys;

/// <summary>
/// Abstract class for Porichthys (genus).
/// NCBI TaxId: 45383
/// </summary>
public abstract class Porichthys : Batrachoididae, IPorichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 45383;

    /// <inheritdoc />
    public virtual string GenusName => "Porichthys";

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
