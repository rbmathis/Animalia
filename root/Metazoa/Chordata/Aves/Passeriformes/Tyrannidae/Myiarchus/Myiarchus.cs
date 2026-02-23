using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiarchus;

/// <summary>
/// Abstract class for Myiarchus (genus).
/// NCBI TaxId: 190695
/// </summary>
public abstract class Myiarchus : Tyrannidae, IMyiarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190695;

    /// <inheritdoc />
    public virtual string GenusName => "Myiarchus";

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
