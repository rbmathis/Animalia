using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Megarynchus;

/// <summary>
/// Abstract class for Megarynchus (genus).
/// NCBI TaxId: 478632
/// </summary>
public abstract class Megarynchus : Tyrannidae, IMegarynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megarynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 478632;

    /// <inheritdoc />
    public virtual string GenusName => "Megarynchus";

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
