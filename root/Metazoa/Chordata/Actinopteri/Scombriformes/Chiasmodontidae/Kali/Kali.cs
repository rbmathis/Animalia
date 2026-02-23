using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Kali;

/// <summary>
/// Abstract class for Kali (genus).
/// NCBI TaxId: 206141
/// </summary>
public abstract class Kali : Chiasmodontidae, IKali
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kali";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206141;

    /// <inheritdoc />
    public virtual string GenusName => "Kali";

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
