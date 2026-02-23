using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Bonasa;

/// <summary>
/// Abstract class for Bonasa (genus).
/// NCBI TaxId: 8999
/// </summary>
public abstract class Bonasa : Phasianidae, IBonasa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bonasa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8999;

    /// <inheritdoc />
    public virtual string GenusName => "Bonasa";

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
