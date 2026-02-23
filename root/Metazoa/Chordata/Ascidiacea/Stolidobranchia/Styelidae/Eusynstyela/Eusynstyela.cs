using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Eusynstyela;

/// <summary>
/// Abstract class for Eusynstyela (genus).
/// NCBI TaxId: 581069
/// </summary>
public abstract class Eusynstyela : Styelidae, IEusynstyela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eusynstyela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 581069;

    /// <inheritdoc />
    public virtual string GenusName => "Eusynstyela";

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
