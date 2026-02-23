using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Halidesmus;

/// <summary>
/// Abstract class for Halidesmus (genus).
/// NCBI TaxId: 1003949
/// </summary>
public abstract class Halidesmus : Pseudochromidae, IHalidesmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halidesmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003949;

    /// <inheritdoc />
    public virtual string GenusName => "Halidesmus";

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
