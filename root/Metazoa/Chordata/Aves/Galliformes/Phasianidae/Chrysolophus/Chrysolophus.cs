using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Chrysolophus;

/// <summary>
/// Abstract class for Chrysolophus (genus).
/// NCBI TaxId: 9087
/// </summary>
public abstract class Chrysolophus : Phasianidae, IChrysolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysolophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9087;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysolophus";

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
