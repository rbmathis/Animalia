using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Ogilbyina;

/// <summary>
/// Abstract class for Ogilbyina (genus).
/// NCBI TaxId: 282253
/// </summary>
public abstract class Ogilbyina : Pseudochromidae, IOgilbyina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ogilbyina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 282253;

    /// <inheritdoc />
    public virtual string GenusName => "Ogilbyina";

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
