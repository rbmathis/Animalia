using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Cnemarchus;

/// <summary>
/// Abstract class for Cnemarchus (genus).
/// NCBI TaxId: 495227
/// </summary>
public abstract class Cnemarchus : Tyrannidae, ICnemarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cnemarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495227;

    /// <inheritdoc />
    public virtual string GenusName => "Cnemarchus";

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
