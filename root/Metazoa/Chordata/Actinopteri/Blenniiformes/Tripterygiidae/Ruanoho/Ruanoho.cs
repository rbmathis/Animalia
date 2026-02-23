using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Ruanoho;

/// <summary>
/// Abstract class for Ruanoho (genus).
/// NCBI TaxId: 879891
/// </summary>
public abstract class Ruanoho : Tripterygiidae, IRuanoho
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ruanoho";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879891;

    /// <inheritdoc />
    public virtual string GenusName => "Ruanoho";

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
