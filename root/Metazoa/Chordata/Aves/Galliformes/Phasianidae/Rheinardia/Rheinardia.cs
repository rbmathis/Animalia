using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Rheinardia;

/// <summary>
/// Abstract class for Rheinardia (genus).
/// NCBI TaxId: 151215
/// </summary>
public abstract class Rheinardia : Phasianidae, IRheinardia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rheinardia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 151215;

    /// <inheritdoc />
    public virtual string GenusName => "Rheinardia";

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
