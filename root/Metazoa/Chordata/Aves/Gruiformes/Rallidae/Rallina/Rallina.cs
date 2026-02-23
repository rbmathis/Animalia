using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Rallina;

/// <summary>
/// Abstract class for Rallina (genus).
/// NCBI TaxId: 547196
/// </summary>
public abstract class Rallina : Rallidae, IRallina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rallina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 547196;

    /// <inheritdoc />
    public virtual string GenusName => "Rallina";

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
