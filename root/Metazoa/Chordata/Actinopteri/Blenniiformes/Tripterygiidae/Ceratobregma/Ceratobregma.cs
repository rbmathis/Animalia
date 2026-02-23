using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Ceratobregma;

/// <summary>
/// Abstract class for Ceratobregma (genus).
/// NCBI TaxId: 3051954
/// </summary>
public abstract class Ceratobregma : Tripterygiidae, ICeratobregma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceratobregma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3051954;

    /// <inheritdoc />
    public virtual string GenusName => "Ceratobregma";

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
