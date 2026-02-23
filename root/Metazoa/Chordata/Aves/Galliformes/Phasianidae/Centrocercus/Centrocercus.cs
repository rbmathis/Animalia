using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Centrocercus;

/// <summary>
/// Abstract class for Centrocercus (genus).
/// NCBI TaxId: 9001
/// </summary>
public abstract class Centrocercus : Phasianidae, ICentrocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9001;

    /// <inheritdoc />
    public virtual string GenusName => "Centrocercus";

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
