using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Crocodilichthys;

/// <summary>
/// Abstract class for Crocodilichthys (genus).
/// NCBI TaxId: 879811
/// </summary>
public abstract class Crocodilichthys : Tripterygiidae, ICrocodilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crocodilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879811;

    /// <inheritdoc />
    public virtual string GenusName => "Crocodilichthys";

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
