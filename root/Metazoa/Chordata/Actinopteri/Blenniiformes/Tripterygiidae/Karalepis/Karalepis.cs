using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Karalepis;

/// <summary>
/// Abstract class for Karalepis (genus).
/// NCBI TaxId: 57813
/// </summary>
public abstract class Karalepis : Tripterygiidae, IKaralepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Karalepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57813;

    /// <inheritdoc />
    public virtual string GenusName => "Karalepis";

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
