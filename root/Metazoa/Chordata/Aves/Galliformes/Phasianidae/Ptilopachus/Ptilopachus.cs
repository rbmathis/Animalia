using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Ptilopachus;

/// <summary>
/// Abstract class for Ptilopachus (genus).
/// NCBI TaxId: 388970
/// </summary>
public abstract class Ptilopachus : Phasianidae, IPtilopachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptilopachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 388970;

    /// <inheritdoc />
    public virtual string GenusName => "Ptilopachus";

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
