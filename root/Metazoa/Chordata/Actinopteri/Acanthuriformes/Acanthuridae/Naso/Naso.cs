using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Naso;

/// <summary>
/// Abstract class for Naso (genus).
/// NCBI TaxId: 75027
/// </summary>
public abstract class Naso : Acanthuridae, INaso
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Naso";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75027;

    /// <inheritdoc />
    public virtual string GenusName => "Naso";

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
