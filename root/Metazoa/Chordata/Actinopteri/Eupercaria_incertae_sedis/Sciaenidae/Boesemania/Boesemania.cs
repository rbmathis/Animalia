using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Boesemania;

/// <summary>
/// Abstract class for Boesemania (genus).
/// NCBI TaxId: 1517487
/// </summary>
public abstract class Boesemania : Sciaenidae, IBoesemania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boesemania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1517487;

    /// <inheritdoc />
    public virtual string GenusName => "Boesemania";

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
