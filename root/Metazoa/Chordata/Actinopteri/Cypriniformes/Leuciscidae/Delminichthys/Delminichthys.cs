using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Delminichthys;

/// <summary>
/// Abstract class for Delminichthys (genus).
/// NCBI TaxId: 883073
/// </summary>
public abstract class Delminichthys : Leuciscidae, IDelminichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Delminichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 883073;

    /// <inheritdoc />
    public virtual string GenusName => "Delminichthys";

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
