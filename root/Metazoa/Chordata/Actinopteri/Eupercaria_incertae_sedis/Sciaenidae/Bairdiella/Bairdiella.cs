using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Bairdiella;

/// <summary>
/// Abstract class for Bairdiella (genus).
/// NCBI TaxId: 278777
/// </summary>
public abstract class Bairdiella : Sciaenidae, IBairdiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bairdiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 278777;

    /// <inheritdoc />
    public virtual string GenusName => "Bairdiella";

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
