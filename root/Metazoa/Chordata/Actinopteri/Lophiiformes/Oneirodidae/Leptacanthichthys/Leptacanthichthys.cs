using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Leptacanthichthys;

/// <summary>
/// Abstract class for Leptacanthichthys (genus).
/// NCBI TaxId: 2499218
/// </summary>
public abstract class Leptacanthichthys : Oneirodidae, ILeptacanthichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptacanthichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2499218;

    /// <inheritdoc />
    public virtual string GenusName => "Leptacanthichthys";

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
