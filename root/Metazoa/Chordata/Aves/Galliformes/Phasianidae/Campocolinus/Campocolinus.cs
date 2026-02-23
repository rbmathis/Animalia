using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Campocolinus;

/// <summary>
/// Abstract class for Campocolinus (genus).
/// NCBI TaxId: 3150812
/// </summary>
public abstract class Campocolinus : Phasianidae, ICampocolinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Campocolinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150812;

    /// <inheritdoc />
    public virtual string GenusName => "Campocolinus";

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
