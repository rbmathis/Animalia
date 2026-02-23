using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Excalfactoria;

/// <summary>
/// Abstract class for Excalfactoria (genus).
/// NCBI TaxId: 2821314
/// </summary>
public abstract class Excalfactoria : Phasianidae, IExcalfactoria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Excalfactoria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821314;

    /// <inheritdoc />
    public virtual string GenusName => "Excalfactoria";

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
