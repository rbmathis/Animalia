using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Miichthys;

/// <summary>
/// Abstract class for Miichthys (genus).
/// NCBI TaxId: 240161
/// </summary>
public abstract class Miichthys : Sciaenidae, IMiichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Miichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240161;

    /// <inheritdoc />
    public virtual string GenusName => "Miichthys";

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
