using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tympanuchus;

/// <summary>
/// Abstract class for Tympanuchus (genus).
/// NCBI TaxId: 9003
/// </summary>
public abstract class Tympanuchus : Phasianidae, ITympanuchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tympanuchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9003;

    /// <inheritdoc />
    public virtual string GenusName => "Tympanuchus";

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
