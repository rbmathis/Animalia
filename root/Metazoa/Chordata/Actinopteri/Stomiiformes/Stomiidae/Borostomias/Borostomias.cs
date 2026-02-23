using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Borostomias;

/// <summary>
/// Abstract class for Borostomias (genus).
/// NCBI TaxId: 473353
/// </summary>
public abstract class Borostomias : Stomiidae, IBorostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Borostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473353;

    /// <inheritdoc />
    public virtual string GenusName => "Borostomias";

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
