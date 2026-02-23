using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Ambassis;

/// <summary>
/// Abstract class for Ambassis (genus).
/// NCBI TaxId: 390299
/// </summary>
public abstract class Ambassis : Ambassidae, IAmbassis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ambassis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390299;

    /// <inheritdoc />
    public virtual string GenusName => "Ambassis";

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
