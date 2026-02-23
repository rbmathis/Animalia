using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Eumicrotremus;

/// <summary>
/// Abstract class for Eumicrotremus (genus).
/// NCBI TaxId: 430038
/// </summary>
public abstract class Eumicrotremus : Cyclopteridae, IEumicrotremus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eumicrotremus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 430038;

    /// <inheritdoc />
    public virtual string GenusName => "Eumicrotremus";

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
