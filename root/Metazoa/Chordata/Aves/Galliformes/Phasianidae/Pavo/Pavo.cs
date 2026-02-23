using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Pavo;

/// <summary>
/// Abstract class for Pavo (genus).
/// NCBI TaxId: 9048
/// </summary>
public abstract class Pavo : Phasianidae, IPavo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pavo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9048;

    /// <inheritdoc />
    public virtual string GenusName => "Pavo";

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
