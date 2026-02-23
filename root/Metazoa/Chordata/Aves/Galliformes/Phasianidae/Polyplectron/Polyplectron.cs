using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Polyplectron;

/// <summary>
/// Abstract class for Polyplectron (genus).
/// NCBI TaxId: 9058
/// </summary>
public abstract class Polyplectron : Phasianidae, IPolyplectron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polyplectron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9058;

    /// <inheritdoc />
    public virtual string GenusName => "Polyplectron";

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
