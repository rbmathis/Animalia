using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Rhizothera;

/// <summary>
/// Abstract class for Rhizothera (genus).
/// NCBI TaxId: 466549
/// </summary>
public abstract class Rhizothera : Phasianidae, IRhizothera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhizothera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 466549;

    /// <inheritdoc />
    public virtual string GenusName => "Rhizothera";

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
