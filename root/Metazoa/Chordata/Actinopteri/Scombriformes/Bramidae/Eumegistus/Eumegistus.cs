using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae.Eumegistus;

/// <summary>
/// Abstract class for Eumegistus (genus).
/// NCBI TaxId: 1219342
/// </summary>
public abstract class Eumegistus : Bramidae, IEumegistus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eumegistus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1219342;

    /// <inheritdoc />
    public virtual string GenusName => "Eumegistus";

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
